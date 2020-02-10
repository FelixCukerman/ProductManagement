export class ResponseGetProductsViewModel {
    constructor(data, totalCount) {
      this.data = data;
      this.totalCount = totalCount;
    }

    public data: Array<ResponseGetProductsViewModelItem>;
    public totalCount: number;
}

export class ResponseGetProductsViewModelItem {
    constructor(id, name, categoryId, categoryType) {
      this.id = id;
      this.name = name;
      this.categoryId = categoryId;
      this.categoryType = categoryType;
    }
  
    public id: number;
    public name: string;
    public categoryId: number;
    public categoryType: string;
}