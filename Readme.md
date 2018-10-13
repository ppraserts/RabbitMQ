# RabitMQ
This project contains labs build concept "Message Queue" by use RabitMQ and .NET Core

## Prerequire
1. Visual Studio Code or Other Text Editor
2. .NET Core
3. Docker

## 00 Run RabitMQ
Run Docker to start RabitMQ
``` docker
docker run -d --hostname localhost --name some-rabbit -p 15672:15672 -p 5672:5672  rabbitmq:3
```

## 01 Hello World
1. Go to Folder 01-HelloWorld
```
cd 01-HelloWorld
```
2. Open Terminal 1 and go to receive folder restore package and run
``` .NET Core
cd recevice
dotnet restore
dotnet run
```
3. Open Terminal 2 and go to send folder restore package and run
``` .NET Core
cd send
dotnet restore
dotnet run
```
4. Test put message on send and monitor your message on receive

Reference: https://www.rabbitmq.com/tutorials/tutorial-one-dotnet.html

## 02 Work Queues
1. Go to Folder 02-WorkQueues
```
cd 02-WorkQueues
```
2. Open 2 Terminals and go to worker folder restore package and run
``` .NET Core
cd Worker
dotnet restore
dotnet run
```
 3. Open Terminal and go to NewTask folder restore package
 ``` .NET Core
cd NewTask
dotnet restore
```
4. In Terminal NewTask run new task for your worker
 ``` .NET Core
dotnet run "Task1"
dotnet run "Task2"
dotnet run "Task3"
```

Reference: https://www.rabbitmq.com/tutorials/tutorial-two-dotnet.html