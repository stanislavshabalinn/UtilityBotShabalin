﻿using UtilityBotShabalin.Models;

namespace UtilityBotShabalin.Services
{
    public interface IStorage
    {
        /// <summary>
        /// Получение сессии пользователя по идентификатору
        /// </summary>
        Session GetSession(long chatId);
    }
}