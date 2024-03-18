namespace BlazorApp1.Models {
    public class ToDoListItem {
        public int Id { get; set; }
        public bool Status { get; set; }
        public string Label { get; set; }

        public ToDoListItem(bool status, string label) { 
            Status = status;
            Label = label;
        }
    }
}
