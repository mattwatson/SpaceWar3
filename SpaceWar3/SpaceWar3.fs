namespace DEMW.SpaceWar3

open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Input;
open System

type SpaceWar3() as this =
    inherit Game()

    let g = new GraphicsDeviceManager(this)

    do
        g.CreateDevice()
        g.ToggleFullScreen()

    let shouldExit = fun () ->
        GamePad.GetState(PlayerIndex.One).Buttons.Back = ButtonState.Pressed ||
        Keyboard.GetState().IsKeyDown(Keys.Escape)

    override this.Initialize() =
        base.Initialize()

    override this.Update(gameTime) =
        if shouldExit() then
            this.Exit()

        base.Update(gameTime);

    override this.Draw(gameTime) =

        g.GraphicsDevice.Clear(Color.CornflowerBlue)

        base.Draw(gameTime)
