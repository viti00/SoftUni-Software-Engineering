class Story {
    constructor(title, creator) {
        this.title = title;
        this.creator = creator;
        this._comments = [];
        this._likes = [];
    }

    get likes() {
        if (this._likes.length == 0) {
            return `${this.title} has 0 likes`;
        }
        else if (this._likes.length == 1) {
            return `${this._likes[0]} likes this story!`;
        }
        else {
            return `${this._likes[0]} and ${this._likes.length - 1} others like this story!`;
        }
    }

    like(username) {
        if (this._likes.includes(username)) {
            throw new Error("You can't like the same story twice!");
        }
        else if (this.creator === username) {
            throw new Error('You can\'t like your own story!');
        }
        else {
            this._likes.push(username);
           return`${username} liked ${this.title}!`;
        }
    }

    dislike(username) {
        if (!this._likes.includes(username)) {
            throw new Error('You can\'t dislike this story!');
        }
        else {
            this._likes = this._likes.filter(x => x !== username);
            return `${username} disliked ${this.title}`;
        }
    }
    count = 1;
    comment(username, content, id) {
        if (id == undefined || this._comments.find(x => x.Id == id) == undefined) {
            id = this.count;
            this._comments.push({ Id: id, Username: username, Content: content, Replies: [] });

            this.count++;

            return `${username} commented on ${this.title}`;
        }

        let com = this._comments.find(x => x.Id == id);
        if (com !== undefined) {
            com.Replies.push({ Id: `${com.Id}.${com.Replies.length + 1}`, Username: username, Content: content });

            return `You replied successfully`;
        }
    }

    toString(sortingType) {
        let result = [];
        result.push(`Title: ${this.title}`);
        result.push(`Creator: ${this.creator}`);
        result.push(`Likes: ${this._likes.length}`);
        result.push('Comments:');
        switch (sortingType) {
            case 'asc':
                if(this._comments.length > 0){
                    this._comments.sort((a, b) => a.Id - b.Id);

                for (const comment of this._comments) {
                    result.push(`-- ${comment.Id}. ${comment.Username}: ${comment.Content}`);
                    for (const reply of comment.Replies.sort((a, b) => a.Username - b.Username)) {
                        result.push(`--- ${reply.Id}. ${reply.Username}: ${reply.Content}`)
                    }
                }
                }
                

            break;
            case 'desc':

                if(this._comments.length > 0){
                    this._comments.sort((a, b) => b.Id - a.Id);
                

                for (const comment of this._comments) {
                    result.push(`-- ${comment.Id}. ${comment.Username}: ${comment.Content}`);
                    for (const reply of comment.Replies.sort((a, b) => b.Username - a.Username)) {
                        result.push(`--- ${reply.Id}. ${reply.Username}: ${reply.Content}`)
                    }
                }
                }
                

            break;
            case 'username':
                
                if(this._comments.length > 0){
                    this._comments.sort((a, b) => a.Username.localeCompare(b.Username));
                    for (const comment of this._comments) {
                        result.push(`-- ${comment.Id}. ${comment.Username}: ${comment.Content}`);
                        for (const reply of comment.Replies.sort((a, b) => a.Username.localeCompare(b.Username))) {
                            result.push(`--- ${reply.Id}. ${reply.Username}: ${reply.Content}`)
                        }
                    }
                }
                
                
            break;
        }
        return result.join('\n');
    }
}

debugger;
let art = new Story("My Story", "Anny");
art.like("John");
console.log(art.likes);
art.dislike("John");
console.log(art.likes);
art.comment("Sammy", "Some Content");
console.log(art.comment("Ammy", "New Content"));
art.comment("Zane", "Reply", 1);
art.comment("Jessy", "Nice :)");
console.log(art.comment("SAmmy", "Reply@", 1));
console.log()
console.log(art.toString('username'));
console.log()
art.like("Zane");
console.log(art.toString('desc'));
