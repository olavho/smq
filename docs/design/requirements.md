# Requirements
([Back to main docs](../index.md))
([Back to design](./index.md))

## MVP (minimum viable product)

### Functional requirements
- The system shall allow users to send messages to a queue.
- The service should be able to process messages from the queue asynchronously.
- The service should be able to dynamically load message handlers based on message type.
- The system should support a status that indicates whether a message is pending, processed, or failed.
- It should be possible to send messages using C# library or SQL stored procedure.
- Messages should be processed in the order they were received (FIFO).
- Messages should serialized using JSON format, and base64-encoded when stored in the database.
- Messages should have an ID, type, payload, metadata, status and created timestamp
- There should be a separate message log table to store message processing history.

### Technical requirements
- The library should be usable from both .NET Framework 4.7.2 (>) and DOTNET applications.
- The library should use SQL Server as the message store.
- The message handling logic should take place in a hosted / windows service.
- Standard logging framework should be used.
- Scripts for creating the database schema should be provided.
- Scripts for provisioning, updating, and operating (start/stop/pause) the service should be provided;

## Future options
- Support for multiple queues.
- Retry logic for failed messages.
- Routing messages to different handlers based on message type.
- Message prioritization.
- Separation between transient and permanent errors.
- Dead-letter queue for messages that cannot be processed.
- Monitoring and alerting on message processing status.
- Callbacks or webhooks for notifying external systems of message processing results / progress.
- Support for other databases (e.g., PostgreSQL, MySQL).
- Support for events vs. commands.
- Support for event sourcing.
- Support docker containers.
- Support Github Actions for CI/CD.
- GitHub issues and project boards for task management.
- Documentation site using MkDocs or similar.
- Logo and branding.
- NuGet package for easy integration.

