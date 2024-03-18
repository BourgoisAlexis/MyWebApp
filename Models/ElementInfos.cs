namespace BlazorApp1.Models {
    public struct ElementInfos {
        public string title;
        public string content;
        public string background;

        public ElementInfos(string title, string content, string background) {
            this.title = title;
            this.content = content;
            this.background = background;
        }
    }
}
