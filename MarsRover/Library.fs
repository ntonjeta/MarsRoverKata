namespace MarsRover

type Board = int [,]

type Orientation =
    | N = 0
    | E = 1
    | S = 2
    | O = 3

type Position = { X: int; Y: int; O: Orientation }

type Move =
    | L
    | R
    | M

type RunningRover = { Board: Board; Rover: Position }

module Board =
    let initialize (x: int) (y: int) (p: Position) =
        let initBoard = Array2D.init x y (putRover)
        let putRover x y p  = 
            for i in x do 
                for j in y do 
                    initBoard.[i = p.X, j = p.Y] <- 1

        putRover


    let updateBoard (r: RunningRover) (m: Move) = r.Board

module Position =
    let toLeft r: Position = { r with O = Orientation.N } //TODO
    let toRigth r: Position = { r with O = Orientation.N } //TODO
    let move (r: RunningRover) (m: Move) = r.Rover


module MarsRover =
    let startMarsRover (x: int) (y: int) (p: Position) =
        { Board = Board.initialize x y p
          Rover = p }

    let moveRover (r: RunningRover) (m: Move) =
        match m with
        | M ->
            { Board = Board.updateBoard r m
              Rover = Position.move r m }
        | R ->
            { r with
                  Rover = Position.toRigth r.Rover }
        | L ->
            { r with
                  Rover = Position.toLeft r.Rover }
