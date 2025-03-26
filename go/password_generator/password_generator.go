package main

import (
	"bufio"
	"fmt"
	"math/rand"
	"os"
)

func main() {
	lenght := 0
	writer := bufio.NewWriter(os.Stdout)
	writer.Flush()
	fmt.Print("Password lenght: ")
	fmt.Scanln(&lenght)
	generatePassword(lenght)
}

// From ascii 48 to ascii 122
func generatePassword(lenght int) {
	inferiorLimit, superiorLimit := 48, 122
	password := []string{}

	for range lenght {
		randomNum := inferiorLimit + rand.Intn(superiorLimit-inferiorLimit+1)
		asciiCode := string(randomNum)
		password = append(password, asciiCode)
	}
	printPassword(password)
}

func printPassword(password []string) {
	for _, value := range password {
		fmt.Print(value)
	}
	println()
}
