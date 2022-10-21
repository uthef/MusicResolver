﻿using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Uthef.MusicResolver
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MusicService
    {
        YouTube, Bandcamp, Deezer, AppleMusic, Spotify, Yandex, SoundCloud, Amazon
    }
}
