import axios from "axios";
import { toast } from "react-toastify";

axios.defaults.baseURL = "https://owlbot.info/api/v4";
axios.defaults.headers.common[
  "Authorization"
] = `Token 1d0d4f757e2d5c82980a05dbd46d0d684649e5bc`;

axios.interceptors.response.use(null, error => {
  const expectedError =
    error.response &&
    error.response.status >= 400 &&
    error.response.status < 500;

  const notFoundError = error.response && error.response.status === 404;

  if (notFoundError) return toast.error("Word not found");

  if (!expectedError) toast.error("An unexpected error occurred.");

  toast.error(error.response.data);
  return Promise.reject(error);
});

export const expectedError = (error, statusCode) =>
  error.response && error.response.status === statusCode;

const service = {
  get: axios.get,
  post: axios.post,
  put: axios.put,
  patch: axios.patch,
  expectedError,
};

export default service;
