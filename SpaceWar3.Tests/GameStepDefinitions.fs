namespace DEMW.SpaceWar3.Tests

module GameStepDefinitions =

    open TickSpec
    open NUnit.Framework
    open DEMW.SpaceWar3

    let mutable game = None

    let [<Given>] ``I am using the default configuration`` () = 
        ()
      
    let [<When>] ``I start a new instance of the program`` () =  
        game <- Some <| new SpaceWar3()
        
        match game with
            
            | Some g -> do
                g.Run()
            
            | _ -> Assert.Fail("could not create instance of SpaceWar3")
      
    let [<Then>] ``it should be full screen`` () =
        match game with
            | Some g -> do     
                g.Dispose()
            | _ -> Assert.Fail("no game was created")