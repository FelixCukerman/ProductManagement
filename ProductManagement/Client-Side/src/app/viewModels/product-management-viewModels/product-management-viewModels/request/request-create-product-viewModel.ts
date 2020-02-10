  export class RequestCreateProductViewModel {
    constructor(name, categoryId) {
      this.name = name;
      this.categoryId = categoryId;
    }
  
    public name: string;
    public categoryId: number;
  }