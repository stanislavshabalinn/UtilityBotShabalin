﻿using UtilityBotShabalin.Models;
using UtilityBotShabalin.Services;
using System.Collections.Concurrent;

namespace UtilityBotShabalin.Services
{
    public class MemoryStorage : IStorage
    {
        /// <summary>
        /// Хранилище сессий
        /// </summary>
        private readonly ConcurrentDictionary<long, Session> _sessions;

        public MemoryStorage()
        {
            _sessions = new ConcurrentDictionary<long, Session>();
        }

        public Session GetSession(long chatId)
        {
            // Возвращаем сессию по ключу, если она существует
            if (_sessions.ContainsKey(chatId))
                return _sessions[chatId];

            // Создаем и возвращаем новую, если такой не было
            var newSession = new Session() { OptionCode = "txt" };
            _sessions.TryAdd(chatId, newSession);
            return newSession;
        }
    }
}