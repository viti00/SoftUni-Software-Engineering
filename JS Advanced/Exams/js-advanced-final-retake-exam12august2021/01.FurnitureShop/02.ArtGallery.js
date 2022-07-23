class ArtGallery{
    constructor(creator){
        this.creator = creator;
        this.possibleArticles = {"picture":200,"photo":50,"item":250};
        this._listOfArticles = [];
        this._guests = []; 
    }

    addArticle(articleModel, articleName, quantity){

        if(!this.possibleArticles.hasOwnProperty(articleModel.toLowerCase())){
            throw new Error('This article model is not included in this gallery!');
        }

        let article = this._listOfArticles.find(x=> x.articleName == articleName);

        if(article != undefined){
            
            article.quantity += Number(quantity);
        }
        else {
            this._listOfArticles.push({articleModel: articleModel.toLowerCase(), articleName: articleName, quantity: Number(quantity)})
        }

        return `Successfully added article ${articleName} with a new quantity- ${quantity}.`;
    }

    inviteGuest (guestName, personality){
        let guest = this._guests.find(x=> x.guestName == guestName);

        if(guest != undefined){
            throw new Error(`${guestName} has already been invited.`);
        }

        let points = 0;

        if(personality == 'Vip'){
            points = 500;
        }
        else if (personality == 'Middle'){
            points = 250;
        }
        else {
            points = 50;
        }

        this._guests.push({guestName: guestName, points: Number(points), purchaseArticle: 0});

        return `You have successfully invited ${guestName}!`;
    }

    buyArticle (articleModel, articleName, guestName){
        let article = this._listOfArticles.find(x=> x.articleName == articleName && x.articleModel == articleModel.toLowerCase());
        let guest = this._guests.find(x=> x.guestName == guestName);

        if(article == undefined){
            throw new Error('This article is not found.');
        }
        if(article.quantity == 0){
            return `The ${articleName} is not available.`;
        }
        if(this._guests == undefined){
            return `This guest is not invited.`;
        }

        if(guest.points >= this.possibleArticles[articleModel.toLowerCase()]){
            guest.points -= this.possibleArticles[articleModel.toLowerCase()];
            guest.purchaseArticle++;

            article.quantity--;
            return `${guestName} successfully purchased the article worth ${this.possibleArticles[articleModel.toLowerCase()]} points.`
        }   
        else {
            return `You need to more points to purchase the article.`;
        }

    }

    showGalleryInfo (criteria){
        let result = [];
        switch(criteria){
            case"article":
                result.push('Articles information:');
                for (const obj of this._listOfArticles) {
                    let [articleModel, articleName, quantity] = Object.keys(obj);
                    result.push(`${obj[articleModel]} - ${obj[articleName]} - ${obj[quantity]}`);
                }
            break;
            case"guest":
                result.push('Guests information:');
                for (const obj of this._guests) {
                    //let [guestName, points, purchaseArticle] = Object.keys(obj);
                    result.push(`${Object.values(obj)[0]} - ${Object.values(obj)[2]}`);
                }
            break;
        }

        return result.join('\n');
    }

}

debugger;
const artGallery = new ArtGallery('Curtis Mayfield'); 
artGallery.addArticle('picture', 'Mona Liza', 3);
artGallery.addArticle('Item', 'Ancient vase', 2);
artGallery.addArticle('picture', 'Mona Liza', 1);
artGallery.inviteGuest('John', 'Vip');
artGallery.inviteGuest('Peter', 'Middle');
artGallery.buyArticle('picture', 'Mona Liza', 'John');
artGallery.buyArticle('item', 'Ancient vase', 'Peter');
console.log(artGallery.showGalleryInfo('article'));
console.log(artGallery.showGalleryInfo('guest'));



