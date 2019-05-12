module Library

open FSharp.Data.Sql

open System.Data.Common

// Connect to a public DB (https://rfam.readthedocs.io/en/latest/database.html)
[<Literal>]
let connString = "Server=mysql-rfam-public.ebi.ac.uk;Database=Rfam;User=rfamro;Port=4497"

[<Literal>]
let dbVendor = Common.DatabaseProviderTypes.MYSQL

[<Literal>]
let indivAmount = 1000

[<Literal>]
let useOptTypes = true

type sql = SqlDataProvider<
            dbVendor,
            connString,
            //ResolutionPath = resPath,
            IndividualsAmount = indivAmount,
            UseOptionTypes = useOptTypes>

let ctx = sql.GetDataContext()

let getIndividuals _ = 
    ctx.Rfam.FamilyLong.Individuals
    //|> Seq.map (fun e -> e.ColumnValues |> Seq.toList)
    //|> Seq.toList
