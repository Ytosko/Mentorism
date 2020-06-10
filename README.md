# **Mentorism v2.0.1**

Mentorism a Server-Client Chat system developed in C# which supports multiple client server system on a certain port number

## Technologies used

1. C#
2. Firebase
3. Firesharp
4. Socket programming [TCP/IP]

## Installation

1. Install the software
2. Open the app
3. Create a new chat or join existing.
4. Cool, now chat!

## Features 

1. Chat code is the port number [In ***TCP/IP*** port number is very important]
2. A well defined GUI for chatting which includes,
          
                    i. Active clients
                   ii. sent messages to selected clients
                  iii. exit chat
                   iv. save chat
                    v. smooth runtime
                  vii. powerful server that can not be destroyed easily
                 viii. very fast refresh rates

4. A proper **GUI** to show saved messages [mac address based]
5. Used Firebase as backend so the server is too fast and easy to maintain.

## How it works

This software was developed using **Microsoft Visual Studio 2019**, **Firebase**, **ServerSocker** using **TCP/IP**
Our aim is to build a complete chat system that will be used under a common network where some clients will be connected to the network. Here is the brief description about the system that how it actually works,

1. **Server** : In this package we get pre-built server which can trigger any time. When a user enter a port number / pin by clicking on "Create chat" the server will load immediately after a small verification about the pin number is valid or not and the server will initiate the required communication setup so that the can join the server. In this system the system automatically scan IP address of the machine and tart the server with the port number and also allow everyone to join the chat using the port number which is the pin here along with the IP address of their machine by which the system allows chatting from different machine under a same network connection.

2. **Client** : When client system is launched the client must enter the pin [Which is the port number] and the name to join the chat room.

3. **Chat room** : Here are details of every fields in the chat room :

   * TextArea and Send button : There are two text box which are for 
 showing messages and typing a new message and a send button.

   * Left side JList : This list includes a scrollbar which contains the name of connected users which updates in every 5 seconds.

   * Right side JList :  This list contains the name of the selected users to whome a clint is sending the message. When the list is empty the message will be sending to everyone connected to the server on the port number

   * Menu-bar : The section of the menu bar : 

   

   - [ ]  Operations
         
    - Save Chat : By clicking save exchanged messages the user is allowed to save the messages to the **Firebase** very easily
    - Save as : This option allow user to save the exchanged messages locally on the device as a text file
   - Exit : This option provide host to destroy the server and kick everyone out of the server and also every connected client to leave the chat room.

   

   - [ ]  Exit Chat :  Exit chat used for getting disconnect from server immidietly.


## Why it is correct

From above description we can get that the software / project fills all of the requirements that is asked to be implemented and also the implementation contains all the base features that were asked to be implemented in the project.  
Also the project runs over the **Firebase** which makes the software is much smoother to use and also almost every possible errors and exceptions are handled in the project. This project is purely build on **C#** with helping of **Firesharp** a third party **API** so the software can connect **Firebase realtime database** which makes the software more efficient.

As the software fills all the requirements, base features and also handles almost every exceptions, so we believe this software is correct as asked. 

## Why it is more useful than previously developed "ChatCheese"

If we take a look on our previously developed **ChatCheese** it was build on **Java** with help of SQL server provided by db4free.net but in this development of Mentorism we build a software based on windows platform in **C#** with **Firebase** using **Firesharp API** which is a big difference here. As we know old **JDBC** connector is too slow and noever developed as Firebase was being developed so keeping and showing records from database is much easier than **ChatCheese**

Although the main concept for multithreaded server is same both on **Mentorism** and **ChatCheese** and for only having the best database of its time is being used in this project for this we consider Mentorism as better than **ChatCheese**

## Source

   - Github : [Mentorism](https://github.com/Ytosko/Mentorism)
   - Package : [Mentorism v2.0.1](https://github.com/Ytosko/Mentorism/releases/tag/V2.0.1)

## Q & A

 1. Does **.NET Framework** need to be installed machine is required to run the file ?
     * Yes, although the file will download required all the files before installing itself!
 2. Minimum requirements for running this software ?
     * 4 GB of Ram with **Windows 10** is enough to run the software perfectly

These are only some of the features of Mentorism
Use & enjoy

## Thanks

**Ytosko**
