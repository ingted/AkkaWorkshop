# Actor Model in F# with Akka.NET and Docker
## Workshop

This session will be a mix of presentation and hands-on labs.  If you want to participate in the hands-on portion, we'll be using the following tools and servers:

## Pre-requisites
  - Visual Studio Code
  - Visual Studio 2015-2017
  - Docker 

There will be a handful of labs that we'll work on.  Most will have a scaffolded solution that contains entities and helper code (along with NuGet packages - using Paket).  You can either code along or view the solutions in hidden files.  All solutions will be placed in a GitHub repo.


### Visual Studio Code
Download: https://code.visualstudio.com

### Visual Studio 
Download: https://www.visualstudio.com/downloads/

### Docker (community edition)
It’s easy to get started with Docker. First, you have to install the Docker Engine on your machine (or your server). Follow the official instructions for Windows 10, Mac, or Linux.

Download: https://www.docker.com/community-edition

### RethinkDB
RethinkDB (to act as a local topic bus)

RethinkDB is an open-source, distributed database built to store JSON documents and effortlessly scale to multiple machines. It's easy to set up and learn and features a simple but powerful query language that supports table joins, groupings, aggregations, and functions.
by default, RethinkDB only accepts connections from localhost, otherwise, `rethinkdb --bind all` will bind to all network interfaces available to the container 

## Workshop Agenda
####	Lab 1:
- Implementing and sending messages to in-proc Actor
- Implementing a Remote Actor System
- Send messages to remote (out-of-proc) Actor 
- Remote deployment of arbitrary actor using <@ code-quotations @>

####	Lab 2:
- Docker images and containers
- Pull & Run Docker images
- Run interactive bash
- Pull, set and run Docker RethinkDB & EventStore

####	Lab 3:
- Implementing a Data Loader using RethinkDB, Reactive Extensions and Akka.NET
- Distribute the work-load using round-robin routing
- Plugging EventStore to Data Loader pipeline

####	Lab 4:
- Distribute work-load in Akka.NET Cluster 
- Converting Data Loader to Akka.NET Cluster
- Implementing a Docker image with Akka.NET Actor-System using DockerFiler
- Distribute work-load in Akka.NET Cluster using Docker




