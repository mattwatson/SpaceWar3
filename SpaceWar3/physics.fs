module DEMW.SpaceWar3.Physics

open Microsoft.Xna.Framework

type Force = { Vector : Vector2; Displacement : Vector2 }

let rotateForce (force : Force) (angle : float) =
    let rotation = Matrix.CreateRotationZ(float32 angle)
    let vector = Vector2.Transform(force.Vector, rotation)
    let displacement = Vector2.Transform(force.Displacement, rotation)
    { Vector = vector; Displacement = displacement }