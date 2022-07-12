function solution(){
    class Post{
        constructor(title, content){
            this.title = title;
            this.content = content;
        }

        toString(){
            return `Post: ${this.title}\nContent: ${this.content}`;
        }
    }

    class SocialMediaPost extends Post{
        constructor(title, content, likes, dislikes){
            super(title, content);

            this.likes = likes;
            this.dislikes = dislikes;
            this.comments = [];
        }

        addComment(comment){
            this.comments.push(comment);
        }

        toString(){
            const result = [
                super.toString(),
                `Rating: ${this.likes - this.dislikes}`,
            ];
            if (this.comments.length > 0) {
                result.push('Comments:');
                this.comments.forEach(c => result.push(` * ${c}`));
            }

            return result.join('\n');
        }
        
    }

    class BlogPost extends Post{
        constructor(title, content, views){
            super(title, content);

            this.views = views;
        }
        view(){
            this.views++;
            return this;
        }

        toString(){
            return `Post: ${this.title}\nContent: ${this.content}\nViews: ${this.views}`;
        }
    }


    return{
        Post,
        SocialMediaPost,
        BlogPost
    }
}

debugger;
const classes = solution();
let post = new classes.Post("Post", "Content");

console.log(post.toString());

let scm = new classes.SocialMediaPost("TestTitle", "TestContent", 25, 30);

scm.addComment("Good post");
scm.addComment("Very good post");
scm.addComment("Wow!");

console.log(scm.toString());
debugger;
let bp = new classes.BlogPost('BlogPost', 'BlogContent', 25);

bp.view();
bp.view();
bp.view();
bp.view();
bp.view();

console.log(bp.title);
console.log(bp.content);
console.log(bp.toString());

