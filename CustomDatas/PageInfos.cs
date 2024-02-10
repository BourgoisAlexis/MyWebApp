namespace BlazorApp1.CustomDatas {
    public struct PageInfos {
        public string id;
        public string name;
        public string buttonId;

        public PageInfos(string id, string name, string buttonId) {
            this.id = id;
            this.name = name;
            this.buttonId = buttonId;
        }
    }
}
