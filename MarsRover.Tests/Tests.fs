module Tests

open Expecto

[<Tests>]
let tests =
    testList "tests"
        [ testCase "use library"
          <| fun _ ->
              let subject = true
              Expect.isTrue subject "I compute, therefore I am." ]
