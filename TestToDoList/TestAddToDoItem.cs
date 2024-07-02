using ToDoList;
using ToDoList.Controller;
namespace TestToDoList
{
    public class TestToDoList
    {
        [Fact]
        public void TestAddToDoItem()
        {
            var toDos = ToDoController.GetAllToDos();
                Assert.Equal(toDos.Count, 0);

            var newToDo = new ToDo
            {
                Id = 0,
                Description = "test",
                DueDate = DateTime.Now.AddDays(7),
                Status = "Active",
                Priority = "Medium"
            };
            
            ToDoController.AddToDoItem(newToDo);
            toDos = ToDoController.GetAllToDos();
            Assert.Equal(toDos.Count, 1);
        }


    }
}