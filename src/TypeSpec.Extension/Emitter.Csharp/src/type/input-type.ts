// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

import {
    AccessFlags,
    SdkBuiltInKinds
} from "@azure-tools/typespec-client-generator-core";
import { InputEnumTypeValue } from "./input-enum-type-value.js";
import { InputModelProperty } from "./input-model-property.js";
import {
    DateTimeKnownEncoding,
    DurationKnownEncoding
} from "@typespec/compiler";

interface InputTypeBase {
    Kind: string;
    Description?: string;
    Deprecation?: string;
}

export type InputType =
    | InputPrimitiveType
    | InputDateTimeType
    | InputDurationType
    | InputLiteralType
    | InputUnionType
    | InputModelType
    | InputEnumType
    | InputArrayType
    | InputDictionaryType
    | InputNullableType;

export interface InputPrimitiveType extends InputTypeBase {
    Kind: SdkBuiltInKinds;
    Encode?: string; // In TCGC this is required, and when there is no encoding, it just has the same value as kind
}

export interface InputLiteralType extends InputTypeBase {
    Kind: "constant";
    ValueType: InputPrimitiveType | InputEnumType; // this has to be inconsistent because currently we have possibility of having an enum underlying the literal type
    Value: string | number | boolean | null;
}

export function isInputLiteralType(type: InputType): type is InputLiteralType {
    return type.Kind === "constant";
}

export type InputDateTimeType = InputUtcDateTimeType | InputOffsetDateTimeType;

interface InputDateTimeTypeBase extends InputTypeBase {
    Encode: DateTimeKnownEncoding;
    WireType: InputPrimitiveType;
}

export interface InputUtcDateTimeType extends InputDateTimeTypeBase {
    Kind: "utcDateTime";
}

export interface InputOffsetDateTimeType extends InputDateTimeTypeBase {
    Kind: "offsetDateTime";
}

export interface InputDurationType extends InputTypeBase {
    Kind: "duration";
    Encode: DurationKnownEncoding;
    WireType: InputPrimitiveType;
}

export interface InputUnionType extends InputTypeBase {
    Kind: "union";
    Name: string;
    VariantTypes: InputType[];
}

export function isInputUnionType(type: InputType): type is InputUnionType {
    return type.Kind === "union";
}

export interface InputModelType extends InputTypeBase {
    Kind: "model";
    Properties: InputModelProperty[];
    Name: string;
    CrossLanguageDefinitionId: string;
    Access?: AccessFlags;
    Usage: string; // TODO -- replace this with UsageFlags in TCGC
    AdditionalProperties?: InputType;
    DiscriminatorValue?: string;
    DiscriminatedSubtypes?: Record<string, InputModelType>;
    DiscriminatorProperty?: InputModelProperty;
    BaseModel?: InputModelType;
}

export function isInputModelType(type: InputType): type is InputModelType {
    return type.Kind === "model";
}

export interface InputEnumType extends InputTypeBase {
    Kind: "enum";
    Name: string;
    CrossLanguageDefinitionId: string;
    ValueType: InputPrimitiveType;
    Values: InputEnumTypeValue[];
    Accessibility?: string;
    Deprecated?: string;
    IsExtensible: boolean;
    Usage: string;
}

export interface InputNullableType extends InputTypeBase {
    Kind: "nullable";
    Type: InputType;
}

export function isInputEnumType(type: InputType): type is InputEnumType {
    return type.Kind === "enum";
}

export interface InputArrayType extends InputTypeBase {
    Kind: "array";
    Name: string;
    ValueType: InputType;
    CrossLanguageDefinitionId: string;
}

export function isInputArrayType(type: InputType): type is InputArrayType {
    return type.Kind === "array";
}

export interface InputDictionaryType extends InputTypeBase {
    Kind: "dict";
    KeyType: InputType;
    ValueType: InputType;
}

export function isInputDictionaryType(
    type: InputType
): type is InputDictionaryType {
    return type.Kind === "dict";
}
