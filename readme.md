
# SMQ (Simple Message Queue)

## Overview
SMQ is a lightweight message queuing system designed to offload functionality to background worker.,

It consists of the following components:

### Projects
1. **Smq.Common**
   - Contains common code, interfaces, and utilities shared across the solution.
   - Provides core functionality for sending, receiving, and processing messages.
   - Includes extensible interfaces for customizing serialization, filtering, and message handling.

2. **Smq.Database**
- Contains database scripts and functions

3. **Smq.Server.Service**
   - A Windows Service implementation of the Smq server.
   - Runs as a background service to process messages continuously.
   - Supports hosting in various environments including as a Windows Service.

3. **Smq.Test**
   - Contains unit tests for the solution components.

## Directory structure
```
smq/
├── src/
│   ├── Smq.Common/
│   ├── Smq.Common.Test/
│   ├── Smq.Service/
├── docs/
└── README.md
```

## Prerequisites
- SQL Server

## License
This project is licensed under the MIT License.