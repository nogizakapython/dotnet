package main

import (
	"bufio"
	"fmt"
	"os"
	"strconv"
)

func main() {
	sc := bufio.NewScanner(os.Stdin)

	sc.Scan()
	number, _ := strconv.Atoi(sc.Text())
	fmt.Println(number)

	if number == 10 {
		fmt.Println(strconv.Itoa(number) + "は10に等しい")
	} else if number > 10 {
		fmt.Println(strconv.Itoa(number) + "は10より大きい")
	} else {
		fmt.Println(strconv.Itoa(number) + "は10未満")
	}
}
