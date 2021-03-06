﻿using System;
namespace Doppelkopf.Models
{
    // if MessageType is Meta, then Subtype has further information
    // token: means that user should memorize the token provided by Text in case of connection issues, so they can reclaim a player
    // join: means that a user has joined with name provided in Text
    // leave: means that a user has left with name provided in Text
    // rename: means that a user has renamed, where Username contains the new name and Text contains the old name
    // userlist: returns a list of all users and whether they are in-game;
    //  Text contains JSON like [{"Username": <username>, "TableID": <tableID>}, ...]
    // tableList: returns a list of all tables
    // tablesUpdated: says that tables are updated

    // if MessageType is Game, then SubType has further information
    // error: some error message with Text being some constant that can be put into a message by client
    public class ServerMessage : Message
    {
        public ServerMessage() { }

        // copy constructor
        public ServerMessage(Message message, string username) : base(message)
        {
            Username = username;
        }

        // let other clients know who wrote the message
        public string Username { get; set; }
    }
}

