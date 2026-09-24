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
	a, _ := strconv.Atoi(sc.Text())
	//fmt.Println("Hello " + name)

	sc.Scan()
	b, _ := strconv.Atoi(sc.Text())

	if a == b {
		fmt.Println("equinox")
	} else {
		fmt.Println("no")
	}

}
