namespace MarsRover

// array2D
type Board = int [,]

// enumeration
type Orientation =
    | N = 0
    | E = 1
    | S = 2
    | O = 3

// discriminated union
type Move =
    | L
    | R
    | M

// record
type Rover = { X: int; Y: int; Or: Orientation }

// record
type RunningRover = { Board: Board; Rover: Rover }

module Rover =
    let toLeft actual: Rover =
        { actual with
              Or = enum ((int actual.Or + 3) % 4) }

    let toRigth actual: Rover =
        { actual with
              Or = enum ((int actual.Or + 1) % 4) }

    let move (actual: Rover) =
        match actual.Or with
        | Orientation.N -> { actual with X = actual.X + 1 }
        | Orientation.S -> { actual with X = actual.X - 1 }
        | Orientation.E -> { actual with Y = actual.Y + 1 }
        | Orientation.O -> { actual with Y = actual.Y - 1 }
        | _ -> actual

module Board =
    let rows (b: Board) = (Array2D.length1 b)
    let cols (b: Board) = (Array2D.length2 b)

    let create (rows: int) (cols: int) (p: Rover) =
        Array2D.init<int> rows cols (fun i j -> if i = p.X && j = p.Y then 1 else 0)

    let update (r: RunningRover) =
        let np = (Rover.move r.Rover)

        let outOfTheBoard =
            np.X > (rows r.Board) || np.Y > (cols r.Board)

        if outOfTheBoard then r.Board else create (rows r.Board) (cols r.Board) np

module MarsRover =
    let startRover (x: int) (y: int) (p: Rover) =
        { Board = Board.create x y p
          Rover = p }

    let moveRover (r: RunningRover) (m: Move) =
        match m with
        | M ->
            { Board = Board.update r
              Rover = Rover.move r.Rover }
        | R ->
            { r with
                  Rover = Rover.toRigth r.Rover }
        | L ->
            { r with
                  Rover = Rover.toLeft r.Rover }

    let print (r: RunningRover) = printfn "%s" (r.Board.ToString())
