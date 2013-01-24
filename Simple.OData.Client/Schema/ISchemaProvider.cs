﻿using System.Collections.Generic;

namespace Simple.OData.Client
{
    public interface ISchemaProvider
    {
        string GetTypesNamespace();
        string GetContainersNamespace();
        IEnumerable<Table> GetTables();
        IEnumerable<Column> GetColumns(Table table);
        IEnumerable<Association> GetAssociations(Table table);
        Key GetPrimaryKey(Table table);
        IEnumerable<Function> GetFunctions();
        IEnumerable<EdmEntityType> GetEntityTypes();
        IEnumerable<EdmComplexType> GetComplexTypes();
    }
}
