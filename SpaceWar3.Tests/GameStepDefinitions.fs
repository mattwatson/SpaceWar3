namespace DEMW.SpaceWar3.Tests

module GameStepDefinitions =

    open TickSpec
    open NUnit.Framework
    open DEMW.SpaceWar3

    let [<Then>] ``fail`` () =
        Assert.Fail()