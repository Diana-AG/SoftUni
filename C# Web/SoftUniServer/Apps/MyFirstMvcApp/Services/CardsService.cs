﻿namespace BattleCards.Services
{
    using BattleCards.Data;

    public class CardsService : ICardsService
    {
        private readonly ApplicationDbContext db;

        public CardsService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void AddCard()
        {
            throw new System.NotImplementedException();
        }
    }
}
