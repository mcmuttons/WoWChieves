module DatabaseReaderTest

open NUnit.Framework
open FsUnit


[<TestFixture>]
type DatabaseReaderTest() =
    let result = DatabaseReader.result

    [<Test>] 
    member x.ResultsAreReturnedFromDatabase() =
        result.HasRows |> should equal true

    [<Test>]
    member x.FirstRowContainsCorrectValues() =
        if result.ReadFirst() then
            result.GetInt32(0)  |> should equal 1
            result.GetString(1) |> should equal "First"