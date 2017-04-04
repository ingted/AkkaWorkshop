#Actor Model in F# with Akka.NET and Docker
##Workshop

This session will be a mix of presentation and hands-on labs.  If you want to participate in the hands-on portion, we'll be using the following tools and servers:

##Pre-requisites
  - Visual Studio Code
  - Visual Studio 2015-2017
  - Docker 
  - RethinkDB (to act as a local topic bus)
  - EventStore (event store)

There will be a handful of labs that we'll work on.  Most will have a scaffolded solution that contains entities and helper code (along with NuGet packages - using Paket).  You can either code along or view the solutions in hidden files.  All solutions will be placed in a GitHub repo.


###Visual Studio Code
Download: https://code.visualstudio.com

###Visual Studio 
Download: https://www.visualstudio.com/downloads/

###Docker (community edition)
Download: https://www.docker.com/community-edition

###RethinkDB
You can download the server here: http://rethinkdb.com/docs/install/
However, it will be used a RethinkDB Docker instance

Download the EXE and place it in a directory of your choice.
Open a command prompt, navigate to your EXE's directory and type:

    rethinkdb.exe --http-port 55000
(The HTTP Port can be of your choosing.  The default port requires you to run the command line as an administrator.)

After running the EXE, open a browser and navigate to

    http://localhost:55000
You should see the RethinkDB dashboard.  Play around with it -- we'll be using it a bit to create new tables and clear out data.


###EventStore
You can download the server here: https://geteventstore.com/downloads/
However, it will be used an EventStore Docker instance

Download the ZIP file and extract it into a directory of your choice.
Open up a command prompt **AS AN ADMINISTRATOR**.
Navigate to where you extracted the ZIP file, and type:

    EventStore.ClusterNode.exe
There are a number of other command line options, so check the documentation for additional details.

Once running, open up a browser and navigate to:

    http://localhost:2113
You should be prompted for credentials.  Type **admin** for the user name and **changeit** for the password.  (You can change these later if you'd like.)
You should then be taken to the EventStore dashboard.

##Workshop Agenda
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

