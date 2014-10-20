namespace TicTacToe.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TicTacToe.Models;

    public sealed class Configuration : DbMigrationsConfiguration<TicTacToeDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TicTacToeDbContext context)
        {
          
        }
    }
}