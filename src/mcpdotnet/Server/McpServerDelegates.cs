﻿using McpDotNet.Protocol.Types;

namespace McpDotNet.Server;

/// <summary>
/// Container for delegates that can be applied to an MCP server.
/// </summary>
public class McpServerDelegates
{
    /// <summary>
    /// Gets or sets the handler for list tools requests.
    /// </summary>
    public Func<RequestContext<ListToolsRequestParams>, CancellationToken, Task<ListToolsResult>>? ListToolsHandler { get; set; }

    /// <summary>
    /// Gets or sets the handler for call tool requests.
    /// </summary>
    public Func<RequestContext<CallToolRequestParams>, CancellationToken, Task<CallToolResponse>>? CallToolHandler { get; set; }

    /// <summary>
    /// Gets or sets the handler for list prompts requests.
    /// </summary>
    public Func<RequestContext<ListPromptsRequestParams>, CancellationToken, Task<ListPromptsResult>>? ListPromptsHandler { get; set; }

    /// <summary>
    /// Gets or sets the handler for get prompt requests.
    /// </summary>
    public Func<RequestContext<GetPromptRequestParams>, CancellationToken, Task<GetPromptResult>>? GetPromptHandler { get; set; }

    /// <summary>
    /// Gets or sets the handler for list resources requests.
    /// </summary>
    public Func<RequestContext<ListResourcesRequestParams>, CancellationToken, Task<ListResourcesResult>>? ListResourcesHandler { get; set; }

    /// <summary>
    /// Gets or sets the handler for read resources requests.
    /// </summary>
    public Func<RequestContext<ReadResourceRequestParams>, CancellationToken, Task<ReadResourceResult>>? ReadResourceHandler { get; set; }

    /// <summary>
    /// Gets or sets the handler for get resources requests.
    /// </summary>
    public Func<RequestContext<CompleteRequestParams>, CancellationToken, Task<CompleteResult>>? GetCompletionHandler { get; set; }

    /// <summary>
    /// Gets or sets the handler for subscribe to resources messages.
    /// </summary>
    public Func<RequestContext<string>, CancellationToken, Task>? SubscribeToResourcesHandler { get; set; }

    /// <summary>
    /// Gets or sets the handler for subscribe to resources messages.
    /// </summary>
    public Func<RequestContext<string>, CancellationToken, Task>? UnsubscribeFromResourcesHandler { get; set; }

    /// <summary>
    /// Applies the delegates to the server.
    /// </summary>
    /// <param name="server"></param>
    public void Apply(IMcpServer server)
    {
        if (server is null)
        {
            throw new ArgumentNullException(nameof(server));
        }

        if (ListToolsHandler != null)
            server.ListToolsHandler = ListToolsHandler;

        if (CallToolHandler != null)
            server.CallToolHandler = CallToolHandler;

        if (ListPromptsHandler != null)
            server.ListPromptsHandler = ListPromptsHandler;

        if (GetPromptHandler != null)
            server.GetPromptHandler = GetPromptHandler;

        if (ListResourcesHandler != null)
            server.ListResourcesHandler = ListResourcesHandler;

        if (ReadResourceHandler != null)
            server.ReadResourceHandler = ReadResourceHandler;

        if (GetCompletionHandler != null)
            server.GetCompletionHandler = GetCompletionHandler;

        if (SubscribeToResourcesHandler != null)
            server.SubscribeToResourcesHandler = SubscribeToResourcesHandler;

        if (UnsubscribeFromResourcesHandler != null)
            server.UnsubscribeFromResourcesHandler = UnsubscribeFromResourcesHandler;
    }
}
