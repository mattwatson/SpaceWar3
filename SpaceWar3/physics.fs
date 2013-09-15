module DEMW.SpaceWar3.Physics
//#r "MonoGame.Framework.dll";
open Microsoft.Xna.Framework

type Force = { Vector:Vector2; Displacement:Vector2 }

type Body = { Mass:float; Position:Vector2; Radius:float }

let zeroForce = {Vector = Vector2.Zero; Displacement = Vector2.Zero}

let rotateForce (force:Force) angle =
    let rotation = Matrix.CreateRotationZ(float32 angle)
    
    {   Vector = Vector2.Transform(force.Vector, rotation)
        Displacement = Vector2.Transform(force.Displacement, rotation)}

let calculateGravitationalForce b1 b2 =

    let gravitationalConstant = 100.

    let diff = b2.Position - b1.Position;
    
    let unitVector =
        let unitVector' = b1.Position - b2.Position
        unitVector'.Normalize()
        unitVector'

    //TODO remove this when proper collision detection has been implemented
    let unitVector = 
        if (float (diff.Length()) <= b1.Radius + b2.Radius)
        then Vector2.Negate(unitVector)
        else unitVector

    let lengthSquared = diff.LengthSquared() |> float
    let scalingFactor = gravitationalConstant * b1.Mass * b2.Mass / lengthSquared |> float32
    { zeroForce with Vector = unitVector * scalingFactor } 

let calculateGravitationalForces bodies =
    let calculateForces body = 
        bodies 
        |> Seq.where (fun x -> (x = body) = false)
        |> Seq.fold (fun list f -> calculateGravitationalForce body f :: list) []

    bodies 
    |> Seq.map (fun body -> body, calculateForces body)

//Tests

let b1 = { Mass = 100.; Position=Vector2(100.f,0.f); Radius= 10. }
let b2 = { Mass = 100.; Position=Vector2(-100.f,0.f); Radius= 10. }
let b3 = { Mass = 100.; Position=Vector2(0.f,-10.f); Radius= 10. }

let bodies = [b1; b2; b3]

calculateGravitationalForces bodies

