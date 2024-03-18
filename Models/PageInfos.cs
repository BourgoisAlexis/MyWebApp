namespace BlazorApp1.Models {
    public struct PageInfos {
        public string id;
        public string name;
        public string icon;

        public PageInfos(string id, string name, string icon) {
            this.id = id;
            this.name = name;
            this.icon = icon;
        }
    }
}
