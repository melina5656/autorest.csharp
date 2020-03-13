// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace xml_service.Models
{
    public partial class ListBlobsResponse : IXmlSerializable
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "EnumerationResults");
            writer.WriteStartAttribute("ServiceEndpoint");
            writer.WriteValue(ServiceEndpoint);
            writer.WriteEndAttribute();
            writer.WriteStartAttribute("ContainerName");
            writer.WriteValue(ContainerName);
            writer.WriteEndAttribute();
            writer.WriteStartElement("Prefix");
            writer.WriteValue(Prefix);
            writer.WriteEndElement();
            writer.WriteStartElement("Marker");
            writer.WriteValue(Marker);
            writer.WriteEndElement();
            writer.WriteStartElement("MaxResults");
            writer.WriteValue(MaxResults);
            writer.WriteEndElement();
            writer.WriteStartElement("Delimiter");
            writer.WriteValue(Delimiter);
            writer.WriteEndElement();
            writer.WriteObjectValue(Blobs, "Blobs");
            writer.WriteStartElement("NextMarker");
            writer.WriteValue(NextMarker);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        internal static ListBlobsResponse DeserializeListBlobsResponse(XElement element)
        {
            ListBlobsResponse result = default;
            result = new ListBlobsResponse(); var serviceEndpoint = element.Attribute("ServiceEndpoint");
            if (serviceEndpoint != null)
            {
                result.ServiceEndpoint = (string)serviceEndpoint;
            }
            var containerName = element.Attribute("ContainerName");
            if (containerName != null)
            {
                result.ContainerName = (string)containerName;
            }
            string value = default;
            var prefix = element.Element("Prefix");
            if (prefix != null)
            {
                value = (string)prefix;
            }
            result.Prefix = value;
            string value0 = default;
            var marker = element.Element("Marker");
            if (marker != null)
            {
                value0 = (string)marker;
            }
            result.Marker = value0;
            int value1 = default;
            var maxResults = element.Element("MaxResults");
            if (maxResults != null)
            {
                value1 = (int)maxResults;
            }
            result.MaxResults = value1;
            string value2 = default;
            var delimiter = element.Element("Delimiter");
            if (delimiter != null)
            {
                value2 = (string)delimiter;
            }
            result.Delimiter = value2;
            Blobs value3 = default;
            var blobs = element.Element("Blobs");
            if (blobs != null)
            {
                value3 = Blobs.DeserializeBlobs(blobs);
            }
            result.Blobs = value3;
            string value4 = default;
            var nextMarker = element.Element("NextMarker");
            if (nextMarker != null)
            {
                value4 = (string)nextMarker;
            }
            result.NextMarker = value4;
            return result;
        }
    }
}
