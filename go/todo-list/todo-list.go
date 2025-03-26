package main

import (
	"bufio"
	"fmt"
	"os"
)

type task struct {
	id          int
	description string
	status      bool
}

func main() {
	writer := bufio.NewWriter(os.Stdout)
	writer.Flush()

	program := true
	option := 0
	taskList := []task{}
	for program {
		fmt.Println("\n====== Todo List App in GO ======")
		fmt.Println("1. List tasks")
		fmt.Println("2. Create task")
		fmt.Println("3. Mark task as completed")
		fmt.Println("0. Exit")

		fmt.Print("Select: ")
		fmt.Scanln(&option)

		switch option {
		case 1:
			for _, v := range taskList {
				fmt.Println(v.id, " ", v.description, " ", v.status)
			}
		case 2:
			fmt.Print("Enter task description: ")
			description := ""
			scanner := bufio.NewScanner(os.Stdin)
			scanner.Scan()
			description = scanner.Text()
			taskList = append(taskList, task{len(taskList) + 1, description, false})
		case 3:
			selected := 0
			for _, v := range taskList {
				if !v.status {
					fmt.Println(v.id, " ", v.description, " ", v.status)
				}
			}
			fmt.Print("Select task to complete (0 to exit): ")
			fmt.Scanln(&selected)
			taskList[selected-1].status = true
		case 0:
			program = false
		default:
			fmt.Println("Error! Select a valid option")
		}
	}
}
