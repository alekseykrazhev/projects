from flask_sqlalchemy import SQLAlchemy
from werkzeug.security import generate_password_hash, check_password_hash
from flask_login import UserMixin, LoginManager


login = LoginManager()
user_database = SQLAlchemy()


class UserModel(UserMixin, user_database.Model):
    __tablename__ = 'users'

    id = user_database.Column(user_database.Integer, primary_key=True)
    email = user_database.Column(user_database.String(80), unique=True)
    username = user_database.Column(user_database.String(100))
    password_hash = user_database.Column(user_database.String())

    def set_password(self, password):
        self.password_hash = generate_password_hash(password)

    def check_password(self, password):
        return check_password_hash(self.password_hash, password)


@login.user_loader
def load_user(id):
    return UserModel.query.get(int(id))
