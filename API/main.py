from fastapi import FastAPI
from pydantic import BaseModel

app = FastAPI()

users = []

class UserCreateRequest(BaseModel):
    userName: str
    email: str
    password: str

class User(BaseModel):
    id: int
    userName: str
    email: str

@app.post("/users")
def create_user(user: UserCreateRequest):
    user_dict = user.dict()
    user_dict["id"] = len(users) + 1
    user = User(**user_dict)
    users.append(user)
    return user

@app.get("/users")
def get_users():
    return users
