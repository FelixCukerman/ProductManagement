export class ResponseGetCategoriesViewModel {
    constructor(categories) {
      this.categories = categories;
    }

    public categories: Array<ResponseGetCategoriesViewModelItem>;
}

export class ResponseGetCategoriesViewModelItem {
    constructor(id, name) {
      this.id = id;
      this.name = name;
    }
  
    public id: number;
    public name: string;
}