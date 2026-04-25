// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Internal.OpenTelemetry
// Classes: 3
// Methods: 0

namespace ThirdParty.Sentry.Sentry.Internal.OpenTelemetry
{
    public class OtelSemanticConventions : Object
    {
        public string AttributeNetTransport;
        public string AttributeNetPeerIp;
        public string AttributeNetPeerPort;
        public string AttributeNetPeerName;
        public string AttributeNetHostIp;
        public string AttributeNetHostPort;
        public string AttributeNetHostName;
        public string AttributeEnduserId;
        public string AttributeEnduserRole;
        public string AttributeEnduserScope;
        public string AttributePeerService;
        public string AttributeHttpMethod;
        public string AttributeHttpUrl;
        public string AttributeHttpTarget;
        public string AttributeHttpHost;
        public string AttributeHttpScheme;
        public string AttributeHttpStatusCode;
        public string AttributeHttpStatusText;
        public string AttributeHttpFlavor;
        public string AttributeHttpServerName;
        public string AttributeHttpRoute;
        public string AttributeHttpClientIP;
        public string AttributeHttpUserAgent;
        public string AttributeHttpRequestContentLength;
        public string AttributeHttpRequestContentLengthUncompressed;
        public string AttributeHttpResponseContentLength;
        public string AttributeHttpResponseContentLengthUncompressed;
        public string AttributeDbSystem;
        public string AttributeDbConnectionString;
        public string AttributeDbUser;
        public string AttributeDbMsSqlInstanceName;
        public string AttributeDbJdbcDriverClassName;
        public string AttributeDbName;
        public string AttributeDbStatement;
        public string AttributeDbOperation;
        public string AttributeDbInstance;
        public string AttributeDbUrl;
        public string AttributeDbCassandraKeyspace;
        public string AttributeDbHBaseNamespace;
        public string AttributeDbRedisDatabaseIndex;
        public string AttributeDbMongoDbCollection;
        public string AttributeRpcSystem;
        public string AttributeRpcService;
        public string AttributeRpcMethod;
        public string AttributeRpcGrpcStatusCode;
        public string AttributeMessageType;
        public string AttributeMessageId;
        public string AttributeMessageCompressedSize;
        public string AttributeMessageUncompressedSize;
        public string AttributeFaasTrigger;
        public string AttributeFaasExecution;
        public string AttributeFaasDocumentCollection;
        public string AttributeFaasDocumentOperation;
        public string AttributeFaasDocumentTime;
        public string AttributeFaasDocumentName;
        public string AttributeFaasTime;
        public string AttributeFaasCron;
        public string AttributeMessagingSystem;
        public string AttributeMessagingDestination;
        public string AttributeMessagingDestinationKind;
        public string AttributeMessagingTempDestination;
        public string AttributeMessagingProtocol;
        public string AttributeMessagingProtocolVersion;
        public string AttributeMessagingUrl;
        public string AttributeMessagingMessageId;
        public string AttributeMessagingConversationId;
        public string AttributeMessagingPayloadSize;
        public string AttributeMessagingPayloadCompressedSize;
        public string AttributeMessagingOperation;
        public string AttributeExceptionEventName;
        public string AttributeExceptionType;
        public string AttributeExceptionMessage;
        public string AttributeExceptionStacktrace;
        public string AttributeClientAddress;
        public string AttributeClientPort;
        public string AttributeHttpRequestMethod;
        public string AttributeHttpResponseStatusCode;
        public string AttributeNetworkProtocolVersion;
        public string AttributeServerAddress;
        public string AttributeServerPort;
        public string AttributeServerSocketAddress;
        public string AttributeUrlFull;
        public string AttributeUrlPath;
        public string AttributeUrlScheme;
        public string AttributeUrlQuery;
        public string AttributeUserAgentOriginal;
    }

    public class OtelSpanAttributeConstants : Object
    {
        public string StatusCodeKey;
        public string StatusDescriptionKey;
        public string DatabaseStatementTypeKey;
    }

    public class OtelStatusTags : Object
    {
        public string UnsetStatusCodeTagValue;
        public string OkStatusCodeTagValue;
        public string ErrorStatusCodeTagValue;
    }

}