﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;
using PetaPocoWebApplication.Infrastructure;
using PetaPocoWebApplication.Models;

namespace PetaPocoWebApplication.Handlers
{
    public class HomeDeleteHandler : ICommandHandler<HomeDeleteInputModel, bool>
    {
        private readonly IDatabase _database;

        public HomeDeleteHandler(IDatabase database)
        {
            _database = database;
        }

        public bool Handle(HomeDeleteInputModel inputModel)
        {
            var i = _database.Delete<Expense>(inputModel.ExpenseId);
            return i == 1;
        }

    }

    public class HomeDeleteInputModel
    {
        public int ExpenseId { get; set; }
    }
}
