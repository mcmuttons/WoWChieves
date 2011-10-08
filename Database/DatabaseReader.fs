module DatabaseReader

open System.Data.SqlServerCe

let path = "E:\\Development\\WoW Achievements\\WoWChieves\\"
let file = "wowchieves.sdf"
let source = "Datasource=" + path + file + ";"
let connection = new SqlCeConnection(source)


let command = new SqlCeCommand("SELECT * FROM TestTable", connection)
let result = 
    connection.Open()
    command.ExecuteResultSet(ResultSetOptions.Scrollable)



