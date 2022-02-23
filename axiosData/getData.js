import axios from "axios";

async function getData(user_id) {
  const { data: user } = await axios(
    `https://jsonplaceholder.typicode.com/users/${user_id}`
  );
  const { data: posts } = await axios(
    `https://jsonplaceholder.typicode.com/posts?userId=${user_id}`
  );
  return { user: user, posts: posts }; // Return the user information and posts belongs to given user_id
}

export default getData;
