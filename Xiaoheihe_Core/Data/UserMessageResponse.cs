﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Xiaoheihe_Core.Data
{
    public sealed class UserMessageResponse : BasicResponse<UserMessageResultData>
    {
    }

    public sealed class UserMessageResultData : BasicResultData
    {
        [JsonPropertyName("recipient")]
        public XhhUserData Receiver { get; set; } = new();

        [JsonPropertyName("list")]
        public HashSet<MessageData> MessageList { get; set; } = new();

        [JsonPropertyName("sender")]
        public XhhUserData Sender { get; set; } = new();

        [JsonPropertyName("newer")]
        public uint Newer { get; set; }

        [JsonPropertyName("older")]
        public uint Older { get; set; }

        public override string? ToString()
        {
            return $"{Sender} => {Receiver}";
        }
    }

    public sealed class MessageData
    {
        private const string Send = "->";
        private const string Recv = "<-";

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("create_time")]
        public DateTime CreateTime { get; set; }

        [JsonPropertyName("is_user")]
        public byte IsSender { get; set; }

        public override string? ToString()
        {
            return $"{(IsSender == 1 ? Send : Recv)} {Text} {CreateTime}";
        }
    }



}