from flask import Flask, render_template, request, redirect
from flask_login import login_required, current_user, login_user, logout_user
import secrets

from models import user_database, login, UserModel

app = Flask(__name__)
secret_key = secrets.token_urlsafe(32)
app.secret_key = secret_key
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///users.db'
app.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = False


user_database.init_app(app)
login.init_app(app)
login.login_view = 'login'


@app.before_first_request
def create_table():
    user_database.create_all()


@app.route('/blogs')
@login_required
def blog():
    return render_template('blog.html')


@app.route('/login', methods=['POST', 'GET'])
def login():
    if current_user.is_authenticated:
        return redirect('/blogs')

    if request.method == 'POST':
        email = request.form['email']
        user = UserModel.query.filter_by(email=email).first()
        if user is not None and user .check_password(request.form['password']):
            login_user(user)
            return redirect('blogs')

    return render_template('login.html')


@app.route('/register', methods=['POST', 'GET'])
def register():
    if current_user.is_authenticated:
        return redirect('/blogs')

    if request.method == 'POST':
        email = request.form['email']
        username = request.form['username']
        password = request.form['password']

        if UserModel.query.filter_by(email=email).first():
            return 'Email is already in use'

        user = UserModel(email=email, username=username)
        user.set_password(password)
        user_database.session.add(user)
        user_database.session.commit()
        return redirect('/login')

    return render_template('register.html')


@app.route('/logout')
def logout():
    logout_user()
    return redirect('/blogs')


@app.route('/')
def main():
    return redirect('/blogs')


if __name__ == '__main__':
    app.run(host='localhost', port=5000)
