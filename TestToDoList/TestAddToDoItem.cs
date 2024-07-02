using ToDoList;
using ToDoList.Controller;
namespace TestToDoList
{
    public class TestToDoList
    {
        [Fact]

       
public void TestAddToDoItem(){
            Assert.Equal(toDos.Count, 0)
            var newToDo = new ToDo
            {
                Id = 0,
                Description = $"{toDoDescription}",
                DueDate = defaultDueDate,
                Status = "Active",
                Priority = "Medium"
            };
            ToDoController.AddToDoItem(newToDo);
            var toDos = ToDoController.getalltodos();

            Assert.Equal(toDos.Count,1)
        }


    }
}