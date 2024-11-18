# TypeSpec Server Emitter Demo Repo

This repository contains a number of TypeSpec API specifications and has been set up to test generated server code.

As the server implementations vary, TypeSpec service emitters currently only generate API artifacts such as Models and Controllers as building blocks. This eliminates the need to synchronize any changes between TypeSpec and the service API surface. With the generated building blocks, you will still need to provide service scaffolding and business logic for a runnable server.

However, in this repository, we have added a small amount of scaffolding code and minimal service stub code so that the demo server projects can all be started for testing. We have provided the steps in the README.md in each folder. If you wish to recreate this folder from scratch or review the scaffolding steps, please see [README.md sections under /servers](./servers/aspnet/README.md).

## Prerequisites

Before you begin, ensure you have met the following requirements:

- You have installed [Node.js](https://nodejs.org/) (version 14.x or later).
- You have installed [npm](https://www.npmjs.com/) (version 6.x or later).
- To test C#/ASP.NET service, please install [.NET](https://dotnet.microsoft.com/en-us/download) (version 8.0 or later).

## Repo Initialization

To install or update TypeSpec and libraries, run the following command **once or every time `package.json` is updated**:

```sh
npm install
```

## Try out generated service code

To try out generated service code for a TypeSpec, please follow the `README.MD` under `/servers/[PLATFORM]/[spec].

Please review [README.md](./servers/aspnet/README.md)

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
