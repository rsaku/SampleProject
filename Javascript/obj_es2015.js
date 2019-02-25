// Animalクラスの定義
class Animal {
	// コンストラクタの定義
	constructor(name) {
		this.name = name;
	}
	// speakメソッドの定義
	speak() {
		console.log(this.name + "「鳴き声」");
	}
	// sleepメソッドの定義
	sleep() {
		console.log(this.name + "「zzz」");
	}
}
// Catクラスの定義
class Cat extends Animal {
	// コンストラクタの定義
	constructor(name) {
		// 親クラスのコンストラクタを実行
		super(name);
	}
	// speakメソッドを定義
	speak() {
		console.log(this.name + "「にゃーん」");
	}
}
// もちろんAnimalやCatは今までと同様に使用可能
// Animalのインスタンスを作成
var myAnimal = new Animal("ポチ");
myAnimal.speak(); // "ポチ「鳴き声」"
myAnimal.sleep(); // "ポチ「zzz」"

// Catのインスタンスを作成
var myCat = new Cat("たま");
myCat.speak(); // "たま「にゃーん」"
myCat.sleep(); // "たま「zzz」"