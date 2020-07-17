using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class ByteTVCommandsMessageModel
    {
        public static Dictionary<string, string> KnownTVCommands { get; } = new Dictionary<string, string>()
            {
                //Power
                {"powerValue", "*SEPOWR################\n"},
                // Power on - power - off
                {"*SAPOWR0000000000000000\n", "*SCPOWR0000000000000001\n"},
                // Power off - power - on
                {"*SAPOWR0000000000000001\n", "*SCPOWR0000000000000000\n"},

                //InfraRedRemoteControl
                    //Volume
                {"volumeUpValue", "*SCIRCC0000000000000030\n"},
                {"volumeDownValue", "*SCIRCC0000000000000031\n"},
                    //Channel
                {"channelUp","SCIRCC0000000000000033\n"},
                {"channelDown","SCIRCC0000000000000034\n"},

                //Mute
                {"muteValue",    "*SEAMUT################\n"},
                // Muted - unmuted.
                {"*SAAMUT0000000000000000\n", "*SCAMUT0000000000000001\n"},
                // Unmuted - Muted.
                {"*SAAMUT0000000000000001\n", "*SCAMUT0000000000000000\n"}
                //{"reboot",       }

            };
    }
}
