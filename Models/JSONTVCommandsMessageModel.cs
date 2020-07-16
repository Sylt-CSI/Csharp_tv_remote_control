using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public class JSONTVCommandsMessageModel
    {
        // Should be private but forgot how to close down the put method.
        public static Dictionary<string, string> KnownTVCommands { get; } = new Dictionary<string, string>()
        {
            {"poweron", "{\"method\": \"setPowerStatus\",\"id\": 55,\"params\": [{\"status\": true}],\"version\": \"1.0\"}" },
            {"poweroff", "{\"method\": \"setPowerStatus\",\"id\": 55,\"params\": [{\"status\": false}],\"version\": \"1.0\"}" },
            {"volumeUp",    "{\"method\": \"setAudioVolume\",\"id\": 601,\"params\": [{\"volume\": \"+1\",\"target\": \"speaker\"}],\"version\": \"1.0\"}" },
            {"volumeDown",  "{\"method\": \"setAudioVolume\",\"id\": 601,\"params\": [{\"volume\": \"-1\",\"target\": \"speaker\"}],\"version\": \"1.0\"}" },
            {"muteOn", "{\"method\":\"setAudioMute\",\"id\":601,\"params\":[{\"status\":true}],\"version\":\"1.0\"}" },
            {"muteOff", "{\"method\":\"setAudioMute\",\"id\":601,\"params\":[{\"status\":false}],\"version\":\"1.0\"}" },
            {"reboot", "{\"method\":\"requestReboot\",\"id\":10,\"params\":[],\"version\":\"1.0\"}" }

        };



    }

    

}
