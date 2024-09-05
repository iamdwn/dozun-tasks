import Dztasks from "../components/Dztasks";
import axiosClient from "./axiosClient";

const END_POINT = {
    DZTASKS: "dztasks"
}

export const getDztasksAPI = () => {
    return axiosClient.get(`${END_POINT.DZTASKS}`);
}

export const delDztasksAPI = (id) => {
    return axiosClient.delete(`${END_POINT.DZTASKS}/${id}`);
}