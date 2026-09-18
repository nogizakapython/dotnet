package main

import (
    "fmt"
    "bufio"
    "os"
)

func main() {
	sc := bufio.NewScanner(os.Stdin)

	sc.Scan()
	name := sc.Text()
	fmt.Println("Hello " + name)
	if name == "go" {
	    fmt.Println("Welcome " + name)
	}
	
}