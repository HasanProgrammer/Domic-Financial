﻿using Karami.Persistence.Contexts.C;

namespace Karami.Infrastructure.Extensions.C;

public static class SQLContextExtension
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    public static void Seed(this SQLContext context)
    {
        #region Account Seeder

        #endregion

        context.SaveChanges();
    }
}