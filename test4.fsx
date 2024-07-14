//変数定義
let x = 20 // int
// 関数定義
let f x = x + 10

// 関数内関数
let g x =
  let g' x = x * x
  g'(f x)

// 再帰関数の定義
let rec fact x =
  if x = 0 then 1
    else x * fact(x - 1)

let hello() =
  System.Console.WriteLine("Hello")
