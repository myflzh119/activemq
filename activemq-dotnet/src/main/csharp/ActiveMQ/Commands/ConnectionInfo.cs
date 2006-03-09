/*
* Copyright 2006 The Apache Software Foundation or its licensors, as
* applicable.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*     http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/

using System;
using System.Collections;

using ActiveMQ.OpenWire;
using ActiveMQ.Commands;

namespace ActiveMQ.Commands
{
    //
    //  Marshalling code for Open Wire Format for ConnectionInfo
    //
    //
    //  NOTE!: This file is autogenerated - do not modify!
    //         if you need to make a change, please see the Groovy scripts in the
    //         activemq-core module
    //
    public class ConnectionInfo : BaseCommand
    {
        public const byte ID_ConnectionInfo = 3;
    			
        ConnectionId connectionId;
        string clientId;
        string password;
        string userName;
        BrokerId[] brokerPath;

		public override string ToString() {
            return GetType().Name + "["
                + " ConnectionId=" + ConnectionId
                + " ClientId=" + ClientId
                + " Password=" + Password
                + " UserName=" + UserName
                + " BrokerPath=" + BrokerPath
                + " ]";

		}
	


        public override byte GetDataStructureType() {
            return ID_ConnectionInfo;
        }


        // Properties

        public ConnectionId ConnectionId
        {
            get { return connectionId; }
            set { this.connectionId = value; }            
        }

        public string ClientId
        {
            get { return clientId; }
            set { this.clientId = value; }            
        }

        public string Password
        {
            get { return password; }
            set { this.password = value; }            
        }

        public string UserName
        {
            get { return userName; }
            set { this.userName = value; }            
        }

        public BrokerId[] BrokerPath
        {
            get { return brokerPath; }
            set { this.brokerPath = value; }            
        }

    }
}
