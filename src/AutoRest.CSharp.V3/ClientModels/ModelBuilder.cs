﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using AutoRest.CSharp.V3.ClientModels.Serialization;
using AutoRest.CSharp.V3.Pipeline.Generated;
using AutoRest.CSharp.V3.Plugins;
using Microsoft.VisualBasic;

namespace AutoRest.CSharp.V3.ClientModels
{
    internal class ModelBuilder
    {
        private readonly KnownMediaType[] _mediaTypes;

        public ModelBuilder(KnownMediaType[] mediaTypes)
        {
            _mediaTypes = mediaTypes;
        }

        private static ClientModel BuildClientEnum(SealedChoiceSchema sealedChoiceSchema) => new ClientEnum(
            sealedChoiceSchema,
            sealedChoiceSchema.CSharpName(),
            sealedChoiceSchema.Choices.Select(c => new ClientEnumValue(c.CSharpName(), ClientModelBuilderHelpers.StringConstant(c.Value))));

        private static ClientModel BuildClientEnum(ChoiceSchema choiceSchema) => new ClientEnum(
            choiceSchema,
            choiceSchema.CSharpName(),
            choiceSchema.Choices.Select(c => new ClientEnumValue(c.CSharpName(), ClientModelBuilderHelpers.StringConstant(c.Value))),
            true);

        private ClientModel BuildClientObject(ObjectSchema objectSchema)
        {
            ClientTypeReference? inheritsFromTypeReference = null;
            DictionarySchema? inheritedDictionarySchema = null;

            foreach (ComplexSchema complexSchema in objectSchema.Parents!.Immediate)
            {
                switch (complexSchema)
                {
                    case ObjectSchema parentObjectSchema:
                        inheritsFromTypeReference = ClientModelBuilderHelpers.CreateType(parentObjectSchema, false);
                        break;
                    case DictionarySchema dictionarySchema:
                        inheritedDictionarySchema = dictionarySchema;
                        break;
                }
            }

            List<ClientObjectProperty> properties = new List<ClientObjectProperty>();

            foreach (Property property in objectSchema.Properties!)
            {
                ClientObjectProperty clientObjectProperty = CreateProperty(property);
                properties.Add(clientObjectProperty);
            }

            Discriminator? schemaDiscriminator = objectSchema.Discriminator;
            ClientObjectDiscriminator? discriminator = null;

            if (schemaDiscriminator == null && objectSchema.DiscriminatorValue != null)
            {
                schemaDiscriminator = objectSchema.Parents!.All.OfType<ObjectSchema>().First(p => p.Discriminator != null).Discriminator;

                Debug.Assert(schemaDiscriminator != null);

                discriminator = new ClientObjectDiscriminator(
                    schemaDiscriminator.Property.CSharpName(),
                    schemaDiscriminator.Property.SerializedName,
                    Array.Empty<ClientObjectDiscriminatorImplementation>(),
                    objectSchema.DiscriminatorValue
                );
            }
            else if (schemaDiscriminator != null)
            {
                discriminator = new ClientObjectDiscriminator(
                    schemaDiscriminator.Property.CSharpName(),
                    schemaDiscriminator.Property.SerializedName,
                    CreateDiscriminatorImplementations(schemaDiscriminator),
                    objectSchema.DiscriminatorValue
                    );
            }

            var schemaTypeReference = ClientModelBuilderHelpers.CreateType(objectSchema, false);

            return new ClientObject(
                objectSchema,
                objectSchema.CSharpName(),
                (SchemaTypeReference?) inheritsFromTypeReference,
                properties.ToArray(),
                discriminator,
                inheritedDictionarySchema == null ? null : CreateDictionaryType(inheritedDictionarySchema),
                BuildSerializations(objectSchema)
                );
        }

        private ObjectSerialization[] BuildSerializations(ObjectSchema objectSchema)
        {
            return _mediaTypes.Select(type => SerializationBuilder.BuildObject(type, objectSchema, isNullable: false)).ToArray();
        }

        private static DictionaryTypeReference CreateDictionaryType(DictionarySchema inheritedDictionarySchema)
        {
            return new DictionaryTypeReference(
                new FrameworkTypeReference(typeof(string)),
                ClientModelBuilderHelpers.CreateType(inheritedDictionarySchema.ElementType, false),
                false);
        }

        private static ClientObjectDiscriminatorImplementation[] CreateDiscriminatorImplementations(Discriminator schemaDiscriminator)
        {
            return schemaDiscriminator.All.Select(implementation => new ClientObjectDiscriminatorImplementation(
                implementation.Key,
                (SchemaTypeReference)ClientModelBuilderHelpers.CreateType(implementation.Value, false),
                schemaDiscriminator.Immediate.ContainsKey(implementation.Key)
            )).ToArray();
        }

        public ClientModel BuildModel(Schema schema) => schema switch
        {
            SealedChoiceSchema sealedChoiceSchema => BuildClientEnum(sealedChoiceSchema),
            ChoiceSchema choiceSchema => BuildClientEnum(choiceSchema),
            ObjectSchema objectSchema => BuildClientObject(objectSchema),
            _ => throw new NotImplementedException()
        };

        private static ClientObjectProperty CreateProperty(Property property)
        {
            bool isReadOnly = property.IsDiscriminator == true || property.ReadOnly == true;

            ClientConstant? defaultValue = null;

            ClientTypeReference type;
            if (property.Schema is ConstantSchema constantSchema)
            {
                type = ClientModelBuilderHelpers.CreateType(constantSchema.ValueType, false);
                defaultValue = ClientModelBuilderHelpers.ParseClientConstant(constantSchema.Value.Value, type);
            }
            else
            {
                type = ClientModelBuilderHelpers.CreateType(property.Schema, property.IsNullable());
                if (property.ClientDefaultValue != null)
                {
                    defaultValue = ClientModelBuilderHelpers.ParseClientConstant(property.ClientDefaultValue, type);
                }
            }

            return new ClientObjectProperty(property.CSharpName(),
                type,
                isReadOnly,
                defaultValue);
        }
    }
}