using System.Collections.Generic;
namespace TodoList.Data
{
    public class TodoItem
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public bool IsEditMode { get; set; }

        private string tmpOriginTitle;
        public void ToggleEditMode()
        {
            if (this.IsEditMode)
            {
                this.Title = tmpOriginTitle;
            }
            else
            {
                tmpOriginTitle = this.Title;
            }

            this.IsEditMode = !this.IsEditMode;
        }

        public void Confirm()
        {
            this.IsEditMode = false;
        }
    }
}