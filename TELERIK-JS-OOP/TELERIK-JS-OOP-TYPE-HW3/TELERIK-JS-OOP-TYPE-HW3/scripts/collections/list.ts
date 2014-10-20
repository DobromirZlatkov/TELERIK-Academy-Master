module Collections {
    export class List<T>{
        private _colletion: T[];

        constructor() {
            this._colletion = [];
        }


        add(item: T) {
            this._colletion.push(item);
        }

        get count() {
            return this._colletion.length;
        }
    }
}

var someList = new Collections.List<number>();
someList.add(10);
